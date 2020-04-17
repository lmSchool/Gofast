function manageResponse(response) {
    responseMessage = document.getElementById("responseMessage");
    responseTxt = "";
    switch (response) {
        case "badFormatUsername":
            responseTxt = "Invalid username, only A-Z, a-z, or 0-9 characters allowed";
            break;
        case "usernameAlreadyTaken":
            responseTxt = "Invalid username, username already taken";
            break;
        case "badFormatEmail":
            responseTxt = "Invalid email";
            break;
        case "emailAlreadyTaken":
            responseTxt = "Invalid email, email already taken";
            break;
        case "passwordsDoNotMatch":
            responseTxt = "Passwords to not match";
            break;
        case "badAgeFormat":
            responseTxt = "Invalid age";
            break;
        case "tooYoung":
            responseTxt = "Invalid age, too young";
            break;
        case "newAccountCreatedSuccessfully":
            response = "New account created successfully, log in";
            responseMessage.color = "green";
            break;
        case "emailNotFound":
            response = "Email not found";
            break;
        case "wrongPassword":
            response = "Wrong Password";
            break;
        case "databaseError":
            response = "Database error, try again later";
            break;
        case "successfullyLoggedIn":
            document.location.href = "192.168.178.26/prova/chat.php"
    }
    responseMessage.innerHTML = responseTxt;
}

function register() {
    /*jQuery.ajax({
        type: "POST",
        url: 'register.php',
        dataType: 'json',
        data: {username: document.getElementById("username").value, email: document.getElementById("email").value, password: document.getElementById("password").value, confirmPassword: document.getElementById("confirmPassword").value, age: document.getElementById("age").value, image: image},
    
        success: function (obj, textstatus) {
                      if( !('error' in obj) ) {
                          yourVariable = obj.result;
                      }
                      else {
                          console.log(obj.error);
                      }
                }
    });*/
    var http = new XMLHttpRequest();
    var url = 'register.php';
    var params = 'username=' + document.getElementById("username").value + "&email=" + document.getElementById("email").value + "&password=" + document.getElementById("password").value + "&confirmPassword=" + document.getElementById("confirmPassword").value + "&age=" + document.getElementById("age").value + "&image=" + document.getElementById("image").value;
    http.open('POST', url, true);

    //Send the proper header information along with the request
    http.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');

    http.onreadystatechange = function() {//Call a function when the state changes.
        if(http.readyState == 4 && http.status == 200) {
            manageResponse(http.responseText);
        }
    }
    http.send(params);
}

function login() {
    var http = new XMLHttpRequest();
    var url = 'login.php';
    var params = "email=" + document.getElementById("email").value + "&password=" + document.getElementById("password").value;
    http.open('POST', url, true);

    //Send the proper header information along with the request
    http.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');

    http.onreadystatechange = function() {//Call a function when the state changes.
        if(http.readyState == 4 && http.status == 200) {
            manageResponse(http.responseText);
        }
    }
    http.send(params);
}

var upload = document.getElementById("upload");
var path = "";
var image = document.getElementById("image").src;

upload.addEventListener("change", function() {
    if (upload.value) {
        const input = document.querySelector("input");
        const curFiles = input.files;
        document.getElementById("image").src = URL.createObjectURL(curFiles[0]);
        var fr = new FileReader();
        fr.readAsDataURL(curFiles[0]);
        fr.onloadend = function() {
            document.getElementById("image").src = (fr.result);
            image = fr.result;
        }
    }
    
    
});

