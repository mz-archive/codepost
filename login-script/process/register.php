<?php 

	function connect(){
		//Подключаемся к БД
		global $conn;
		$user = 'root';
		$password = '';
		$host = 'localhost';
		$DB = 'test2';
		$conn = mysql_connect($host, $user, $password);
		
		//Настраиваем кодировки в выбранной БД
		mysql_select_db($DB, $conn);
		mysql_query("SET NAMES utf8");
		mysql_query("SET character_set_client='UTF-8'");
		mysql_query("SET character_set_results='UTF-8'");
		mysql_query("SET collation_connection='UTF-8'");
		//Проверка соединения
		/*
		if (!$conn){	
			die('Ошибка соединения: ' . mysql_error());
		}
		else{ 
			echo "<p style=\"color: #00FF00;\">Успешно соединились</p><br/>";
		}
		*/
	}
	
	connect();
	
	//Получаем данные формы из массива POST
	$getLogin = $_POST['log'];
	$getPassword = $_POST['pas'];
	$getMail = $_POST['mail'];
	
	$correctMail = mysql_query("SELECT * FROM DataOfForm WHERE descip_s = '".$getMail."'");
	
	while($dataForm = mysql_fetch_array($correctMail, MYSQL_ASSOC))
		{
			
				$dbLogin = $dataForm["login_s"];
				$dbPassword = $dataForm["pass_s"];
				$dbMail = $dataForm["descip_s"];
				
		}
		mysql_free_result($correctMail);
		
	if ($getMail == $dbMail){
		if (($getLogin == $dbLogin) && ($getPassword == $dbPassword)){
			echo "<p align = \"center\" style=\"color: #FF0000; font-size:20px; margin-top:50px;\">Данные совпали!</p>";
			include "../content.php";
		}
		else if (($getLogin != $dbLogin) && ($getPassword == $dbPassword)){
			echo "<p align = \"center\" style=\"color: #FF0000; font-size:20px; margin-top:50px;\">Все верно кроме логина! Попробуйте снова!</p>";
			include "../login.php";
		}
		else if (($getLogin == $dbLogin) && ($getPassword != $dbPassword)){
			echo "<p align = \"center\" style=\"color: #FF0000; font-size:20px; margin-top:50px;\">Все верно кроме пароля! Попробуйте снова!</p>";
			include "../login.php";
		}
		else{
			echo "<p align = \"center\" style=\"color: #FF0000; font-size:20px; margin-top:50px;\">Логин и пароль неверны! Попробуйте снова!</p>";
			include "../login.php";
		}
		
	}
	else{
		include "../reg.php";		
	}
	
	mysql_close($conn);

?>