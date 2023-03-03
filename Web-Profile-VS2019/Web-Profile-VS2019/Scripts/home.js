
const static_privateData = (

    function () {

        // local variables

        const apiData = [{

            listItem: 'http://localhost:3000/home',

            createbtn: document.getElementById('newCreate'),

        }];

        return {

            get(index) {

                return apiData[index];
            }
        }
    }
)();




function homeApp() {

    getHomeItem(renderHomeItem);

    getHomeItem(function (api) {


        console.log(api)
    });

    handleCreateForm();

}

homeApp();




function music() {

    var audio = new Audio("../image/anhkhongthathu.mp3")

    audio.volume = 0.05;
    audio.loop = true;



    console.log("clickk");

    audio.play();


}

function topDown() {


    let scrollPane = document.querySelector('.drop-down');

    scrollPane.onclick = function () {

        console.log("click");


    }
}

function scrollClick(click) {

    let obj1 = {

        top: click,
        left: 0,
        behavior: 'smooth'
    }


    window.scrollTo(obj1);
    console.log("click");

}


function getHomeItem(call) {

    fetch(static_privateData.get(0).listItem)


        .then(function (response) {

            console.log("FAKE API is running...");

            return response.json();
        })

        .then(call).catch(function (error) {

            var listApiBlock = document.querySelector(".home_api_error");

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

        let notification = document.querySelector('.home_api_error');

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

    fetch(static_privateData.get(0).listItem, option)

        .then(function (response) {

            console.log(response);
            response.json();

        }).then(call).catch(async function (error) {


            await errorMessage("Hệ thống đang bảo trì");

        });
}

function renderHomeItem(myAPI) {

    var listApiBlock = document.querySelector(".list_api");


    var html = myAPI.map((api) => {


        return `<div class="knowlegdeItem_id_${api.id}">
                <h2 id="iTem">Framework ${api.id}</h2>
                <p class="animate_img"><img width: 300px; class="my-image" src="${api.img}"></p>
                <h2 class="animate_text" style="color: white;font-size: 15px;word-break: break-word;">${api.text}</h2>
                <button class="deleteFeed" onclick = "handleDeleteHomeItem(${api.id});">
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

        getKnowledge(renderKnowledge);

    });
}


function handleDeleteHomeItem(id) {

    var option = {

        method: 'DELETE',
        headers: {

            'Content-Type': 'application/json',
        },
    }

    fetch(static_privateData.get(0).listItem + "/" + id, option)

        .then(function (response) {

            console.log(response.url);

            response.json();
        })

        .then(function () {

            let ApiItem = document.querySelector(".knowlegdeItem_id_" + id);

            ApiItem.remove();
        });

    console.log(id);
}