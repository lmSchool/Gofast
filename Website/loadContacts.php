<?php
    header('Content-Type: application/json');

    $DBip = "";
    $DBuser = "";
    $DBpassword = "";
    $DBdatabase = "";

    $conn = new mysqli($DBip, $DBuser, $DBpassword, $DBdatabase);

    session_start();

    $id = $_SESSION["id"];
    $email = $_SESSION["email"];
    $password = $_SESSION["password"];
    $image = $_SESSION["image"];

    $username = $conn->query("SELECT user FROM account WHERE id = '$id'");

    $response = array();
    $friends = array();

    $result = $conn->query("SELECT * FROM friends WHERE user = '$username' OR friend = '$username'");
    while ($friend = mysqli_fetch_array($result)) {
        $name = $friend["friend"];
        if ($name === $username)
            $name = $friend["user"];
        if(!in_array($name, $friends))
            $friends[] = $name;
    }

    $response = array();
    for($i = 0; $i < sizeof($friends); $i++) {
        echo $friends[$i];
        $result = mysqli_fetch_array($conn->query("SELECT * FROM account WHERE user = '$friends[$i]'"));
        $response[] = ["image" => $result[""], "name" => $result["user"], "id" => $result["id"], "state" => $result["state"]];
    }

    echo json_encode($response);
?>
