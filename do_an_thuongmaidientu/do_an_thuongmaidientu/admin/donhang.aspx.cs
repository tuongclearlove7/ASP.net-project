using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace do_an_thuongmaidientu.admin
{
    public partial class donhang : System.Web.UI.Page
    {
        Models.ketnoi_database ketnoi = new Models.ketnoi_database();

        protected void ds_donhang_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int soluong = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "soluong"));
                double dongia = Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "dongia"));
                double thanhTien = soluong * dongia;
                Label thanhTienLabel = (Label)e.Row.FindControl("thanhtien");
                thanhTienLabel.Text = thanhTien.ToString();
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                CheckBoxList checkBoxList1 = (CheckBoxList)e.Row.FindControl("CheckBoxList1");
                string mahang = DataBinder.Eval(e.Row.DataItem, "mahang").ToString();

                List<string> maHangList = GetMaHangList(mahang);

                foreach (string maHang in maHangList)
                {
                    ListItem item = new ListItem();
                    item.Value = maHang;
                    item.Text = "";
                    checkBoxList1.Items.Add(item);
                }
            }


        }

        private List<string> GetMaHangList(string mahang)
        {
            List<string> maHangList = mahang.Split(',').ToList();
            maHangList = maHangList.Select(m => m.Trim()).ToList();
            return maHangList;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["tendangnhap"] != null)
                {
                    if (Session["tendangnhap"].ToString() == "admin")
                    {
                        string sql2 = "select * from mathang, donhang where mathang.mahang = donhang.mahang order by mathang.dongia asc";
                        ds_donhang.DataSource = ketnoi.docdulieu(sql2);
                        ds_donhang.DataBind();
                        if (ds_donhang.Rows.Count == 0)
                        {
                            ds_donhang = null;
                            tongthanhtien.Text = "Không đơn hàng nào";
                        }
                        else
                        {
                            ds_donhang.DataBind();
                            string sql3 = "select sum(dongia * soluong) from mathang, donhang where mathang.mahang = donhang.mahang ";
                            DataTable dt = new DataTable();
                            dt = ketnoi.docdulieu(sql3);
                            var tong = dt.Rows[0][0];
                            tongthanhtien.Text = "Tổng thành tiền : " + tong;
                            string sql_count = "select count(*) from mathang, donhang where mathang.mahang = donhang.mahang ";
                            DataTable dt_count = new DataTable();
                            dt_count = ketnoi.docdulieu(sql_count);
                            var count = dt_count.Rows[0][0];
                            dem_sodon.Text = "Số đơn hàng " + count;
                        }
                    }
                    else
                    {
                        Response.Redirect("../user/homeUser.aspx");
                    }
                }
                else
                {
                    Response.Redirect("../master/loginPage.aspx");
                }
            }
        }

        protected void xoa(object sender, EventArgs e)
        {

            List<string> selectedMaHangList = new List<string>();

            foreach (GridViewRow row in ds_donhang.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBoxList checkBoxList1 = (CheckBoxList)row.FindControl("CheckBoxList1");

                    if (checkBoxList1 != null && checkBoxList1.Items.Count > 0)
                    {
                        foreach (ListItem item in checkBoxList1.Items)
                        {
                            if (item.Selected)
                            {
                                selectedMaHangList.Add(item.Value);

                            }
                        }
                    }
                }
            }

            if (selectedMaHangList.Count > 0)
            {
                // xóa nhiều hàng cùng 1 lúc
                foreach (GridViewRow row in ds_donhang.Rows)
                {
                    TextBox txt_mahang = row.FindControl("textbox_mahang") as TextBox;
                    string mahang = txt_mahang.Text;
                    string sql = "DELETE FROM donhang WHERE donhang.mahang IN ('" + string.Join("','", selectedMaHangList) + "')";
                    ketnoi.capnhat(sql);

                }
                Response.Redirect("donhang.aspx");
            }
        }


    }
}