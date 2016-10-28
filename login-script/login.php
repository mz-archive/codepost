<!DOCTYPE html>

<html>
	<head>
		<title>Форма авторизации</title>
		<meta charset="utf-8"/>
		<link rel="stylesheet" href="/sign-in/styles/bootstrap.css">
		<link rel="stylesheet" href="/sign-in/styles/style.css">
	</head>
	<body>
		<div align="center">
			<form action="/sign-in/process/email.php" method="POST">
				<fieldset>
					<legend>Авторизация на сайте</legend>
						<label>Логин: &nbsp; &nbsp; <input type="text" name="log" placeholder="Введите логин" required></label>
						<label>Пароль: &nbsp; <input type="password" name="pas" placeholder="Введите пароль" required></label>
						<label>E-mail: &nbsp; &nbsp; <input type="email" name="mail" placeholder="Введите e-mail" required></label>
						<input type="submit"  value="Войти" class="btn btn-primary">
						<input type="reset" value="очистить форму" class="btn btn-danger">
				</fieldset>
			</form>
		</div>
	</body>
</html>