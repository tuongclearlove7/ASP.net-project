
const privateApp = (

    function () {

        // local variables

        const apiData = [{

            listItem: 'http://localhost:3000/image',

            createbtn: document.getElementById('newCreate'),

        }];

        return {

            get(index) {

                return apiData[index];
            }
        }
    }
)();




function productApp() {

    getProductItem(renderProductItem);
    handleCreateForm();

}

productApp();


function getProductItem(call) {

    fetch(privateApp.get(0).listItem)


        .then(function (response) {

            console.log("FAKE API is running...");

            return response.json();
        })

        .then(call).catch(function (error) {

            var listApiBlock = document.querySelector(".list_api_error");

            let notification = "Hệ thống FAKE API đã tắt!!!";

            let link_imgErr1 = "../image/error1.png";

            console.log(error);

            console.log(notification);

            return listApiBlock.innerHTML = `
            <div class= "content-block">
               <h1 style="font-size:23px;">${error}</h1>
                  <p>${notification}</p>
                 <div class="errImg"><img src="${link_imgErr1}" alt=""></div>

                 <p style="font-style: oblique;"></p>
            </div>`;
        })
}

function errorMessage(message) {

    let my_promise = new Promise(function (resolve, reject) {

        reject(message);

    });

    my_promise.then(function (success) {

        console.log(success)

    }).catch(function (err) {

        let notification = document.querySelector('.list_api_error');

        notification.innerHTML = `<p>${err}</p>`

    });

    return my_promise;
}


function createFeed(data, call) {

    var option = {

        method: 'POST',
        headers: {

            'Content-Type': 'application/json',
        },

        body: JSON.stringify(data),
    }

    fetch(privateApp.get(0).listItem, option)

        .then(function (response) {

            console.log(response);
            response.json();

        }).then(call).catch(async function (error) {


            await errorMessage("Hệ thống đang bảo trì");

        });
}

function renderProductItem(myAPI) {

    var listApiBlock = document.querySelector(".list_api");


    var html = myAPI.map((api) => {


        return `<div class="knowlegdeItem_id_${api.id}">
                <h2 id="product">Product ${api.id}</h2>
                <p><img width: 300px; class="my-image" src="${api.img}"></p>
                <button class="deleteFeed" onclick = "handleDeleteProductItem(${api.id});">
                xóa</button>
                </div>
                <br>`;

    });

    listApiBlock.innerHTML = html.join('');
}

function handleCreateForm() {

    var name = document.querySelector('input[name="name"]').value;
    var description = document.querySelector('input[name="description"]').value;
    var formData = {

        name: name,
        description: description
    }

    createFeed(formData, function () {

        getProductItem(renderProductItem);

    });
}


function handleDeleteProductItem(id) {

    var option = {

        method: 'DELETE',
        headers: {

            'Content-Type': 'application/json',
        },
    }

    fetch(privateApp.get(0).listItem + "/" + id, option)

        .then(function (response) {

            console.log(response.url);

            response.json();
        })

        .then(function () {

            let apiBlock = document.querySelector(".knowlegdeItem_id_" + id);

            apiBlock.remove();
        });

    console.log(id);
}

