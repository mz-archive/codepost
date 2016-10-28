<?php

/**
 * Обработчик формы
 * @author Дизайн студия ox2.ru 
 */
	//Если форма была отправленна, то выводим ее содержимое на экран
	// if (isset($_POST["name"])) { 
	//     //Данные отправляются в кодировке utf-8, поэтому конвертим в cp1251
	//     echo "Ваше имя: " . iconv("utf-8", "utf-8", $_POST["name"]) . "<br/>"; 
	//     echo "Ваш телефон: " . $_POST["phone-number"] . "<br/>";
	// }
	global $_LANG;
	echo $_LANG['ADMINISTRATOR_EMAIL'];
	echo $settings["notification_email_to"];
	echo $uga;

?>