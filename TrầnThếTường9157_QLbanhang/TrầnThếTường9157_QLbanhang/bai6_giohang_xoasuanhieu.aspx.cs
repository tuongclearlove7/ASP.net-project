using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrầnThếTường9157_QLbanhang
{
    public partial class bai6_giohang_xoasuanhieu : System.Web.UI.Page
    {

        lopketnoi ketnoi = new lopketnoi();

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
                    ListItem item = new ListItem(maHang);
                    checkBoxList1.Items.Add(item);
                }
            }

            if (e.Row.RowType == DataControlRowType.DataRow && (e.Row.RowState & DataControlRowState.Edit) == DataControlRowState.Edit)
            {
                TextBox textbox_soluong = (TextBox)e.Row.FindControl("textbox_soluong");
                if (textbox_soluong != null)
                {
                    textbox_soluong.Text = ((DataRowView)e.Row.DataItem)["soluong"].ToString();
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
                string mahang = HttpContext.Current.Items["mahang"] as string;
                string soluong = HttpContext.Current.Items["soluong"] as string;

                string sql = "select * from mathang, donhang where mathang.mahang = donhang.mahang";
                ds_donhang.DataSource = ketnoi.docdulieu(sql);
                ds_donhang.DataBind();
                string sql2 = "select sum(dongia * soluong) from mathang, donhang where mathang.mahang = donhang.mahang";
                DataTable dt = new DataTable();
                dt = ketnoi.docdulieu(sql2);
                var tong = dt.Rows[0][0];
                tongthanhtien.Text = "Tổng thành tiền : " + tong;
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
                    TextBox txt_soluong = row.FindControl("textbox_soluong") as TextBox;
                    TextBox txt_mahang = row.FindControl("textbox_mahang") as TextBox;
                    string soluong = txt_soluong.Text;
                    string mahang = txt_mahang.Text;
                    string sql = "DELETE FROM donhang WHERE donhang.mahang IN ('" + string.Join("','", selectedMaHangList) + "')";
                    ketnoi.docdulieu(sql);

                }
                // Response.Write("Câu lệnh SQL: " + sql);
                Response.Redirect("bai6_giohang_xoasuanhieu.aspx");
            }
        }

        protected void sua(object sender, EventArgs e)
        {
            List<string> updateValues = new List<string>();
            foreach (GridViewRow row in ds_donhang.Rows)
            {
                TextBox txt_soluong = row.FindControl("textbox_soluong") as TextBox;
                TextBox txt_mahang = row.FindControl("textbox_mahang") as TextBox;
                string soluong = txt_soluong.Text;
                string mahang = txt_mahang.Text;
                string updateValue = "WHEN " + mahang + " THEN " + soluong;
                updateValues.Add(updateValue);
            }
            string sql = "UPDATE donhang SET soluong = CASE mahang " +
                                 string.Join(" ", updateValues) +
                                 " END WHERE mahang IN (" +
                                 string.Join(",", updateValues.Select(v => v.Split(' ')[1])) + ")";
            ketnoi.docdulieu(sql);
            Thread.Sleep(1000);
            Response.Redirect("bai4_giohang.aspx");

        }

    }
}