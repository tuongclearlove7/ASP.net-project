﻿
const privateData = (

    function () {

        // local variables

        const apiData = [{

            list_knowledge: 'http://localhost:3000/about',

            createbtn: document.getElementById('newCreate'),

        }];

        return {

            get(index) {

                return apiData[index];
            }
        }
    }
)();



function aboutApp() {

    getAboutItem(renderAboutItem);
    handleCreateForm();

}

aboutApp();


function getAboutItem(call) {

    fetch(privateData.get(0).list_knowledge)


        .then(function (response) {

            console.log("FAKE API is running...");

            return response.json();
        })

        .then(call).catch(function (error) {

            var listKnowlegdeBlock = document.querySelector(".about_api_error");

            let notification = "Hệ thống FAKE API đã tắt!!!";

            let link_imgErr1 = "../image/error1.png";

            console.log(error);

            console.log(notification);

            return listKnowlegdeBlock.innerHTML = `
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

        let notification = document.querySelector('.about_api_error');

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

    fetch(privateData.get(0).list_knowledge, option)

        .then(function (response) {

            console.log(response);
            response.json();

        }).then(call).catch(async function (error) {


            await errorMessage("Hệ thống đang bảo trì");

        });
}

function renderAboutItem(myKnowledge) {

    var listKnowlegdeBlock = document.querySelector(".api-about");


    var html = myKnowledge.map((knowledge) => {


        return `<div class="knowlegdeItem_id_${knowledge.id}">
                
                <h4 class="my-info">My Info</h4>
                <p><img width: 300px; class="image-about" src="${knowledge.img}"></p>
                <h1 id="info-id">id : @Viewbag.infomation.id</h1>
                <h1 id="info-id">name : @Viewbag.infomation.name</h1>
                <h1 id="info-id">firstname : @Viewbag.infomation.firstname</h1>
                <h1 id="info-id">lastname : @Viewbag.infomation.lastname</h1>
                <h1 id="info-id">fullname : @Viewbag.infomation.fullname</h1>
                <h1 id="info-id">nickname : @Viewbag.infomation.nickname</h1>
                <h1 id="info-id">email : @Viewbag.infomation.email</h1>
                <button class="delete-about" onclick = "handleDeleteAboutItem(${knowledge.id});">
                xóa</button>
                </div>
                <br>`;

    });

    listKnowlegdeBlock.innerHTML = html.join('');
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


function handleDeleteAboutItem(id) {

    var option = {

        method: 'DELETE',
        headers: {

            'Content-Type': 'application/json',
        },
    }

    fetch(privateData.get(0).list_knowledge + "/" + id, option)

        .then(function (response) {

            console.log(response.url);

            response.json();
        })

        .then(function () {

            let knowledgeItem = document.querySelector(".knowlegdeItem_id_" + id);

            knowledgeItem.remove();
        });

    console.log(id);
}
