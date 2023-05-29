setInterval(demgio, 1000);

function demgio() {
    const daytime = new Date();
    document.getElementById("dongthoigian").innerHTML = daytime.toLocaleTimeString();
}


