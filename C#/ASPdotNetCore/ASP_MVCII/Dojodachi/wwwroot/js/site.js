function load(event){
    event.preventDefault();
    var path = event.target.getAttribute("href")
    $.get(path, function(data){
        $("#app").html(data)
    });
}


