var client = new XMLHttpRequest();

client.open('Get', 'https://ghibliapi.herokuapp.com/films', true);

client.onload = function () {
    var films = JSON.parse(this.response);

    var rootElement = document.getElementById('root');

    var table = document.createElement('table');
    var thead = document.createElement('thead');
    var trh = document.createElement('tr');
    var td1 = document.createElement('td');
    td1.innerText = 'Title';
    var td2 = document.createElement('td');
    td2.innerText = 'Description';
    var td3 = document.createElement('td');
    td3.innerText = 'Title';
    var td4 = document.createElement('td');
    td4.innerText = 'Description';
    trh.appendChild(td1);
    trh.appendChild(td2);
    trh.appendChild(td3);
    trh.appendChild(td4);
    thead.appendChild(trh);
    table.appendChild(thead);

    films.forEach(function (movie) {
        var tr = document.createElement('tr');
        var studentIdTd = document.createElement('td');
        studentIdTd.innerText = movie.title;
        tr.appendChild(studentIdTd);

        var firstnameTd = document.createElement('td');
        firstnameTd.innerText = movie.description;
        tr.appendChild(firstnameTd);

        var lastnameTd = document.createElement('td');
        lastnameTd.innerText = movie.description;
        tr.appendChild(lastnameTd);


        var ageTd = document.createElement('td');
        ageTd.innerText = movie.title;
        tr.appendChild(ageTd);

        table.appendChild(tr);

    });

    rootElement.appendChild(table);

}

client.send();