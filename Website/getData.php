<?php
    header('Content-Type: application/json');
    session_start();

    $response = ["email" => $_SESSION["email"], "password" => $_SESSION["password"], "image" => $_SESSION["image"], "id" => $_SESSION["id"], "username" => $_SESSION["username"]];
    echo json_encode($response);
?>
