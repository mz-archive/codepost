<!DOCTYPE html>

<html>
	<head>
		<title>Форма авторизации</title>
		<meta charset="utf-8"/>
		<link rel="stylesheet" href="/sign-in/styles/bootstrap.css">
		<link rel="stylesheet" href="/sign-in/styles/style.css">
	</head>
	<body>
		<h1 align="center">Вы авторизовались!</h1>
		<h2 align="center"><?php echo "Добро пожаловать: <font color=\"blue\">" . $getLogin . "</font>"?></h2>
		
		<?php 
			

			require_once 'ParseLib/simple_html_dom.php'; 
			
			
			$html = new simple_html_dom();
			$html = file_get_html('http://www.e1.ru/afisha/kino/');
			
			
			
			// Получение ссылок на картинки
			$i = 0;
			$t = 0;
			foreach($html->find('img[align=left]') as $element)
			{
				$i += 1;
				$t += 1;
				if ($i == 33)
				{
					$t = 34;
					continue;
				}
				$arrSrc[$t] = 'http://e1.ru' . $element->src;
				
			}
			
			
			// Получение названий
			$i = 0;
			$t = 0;
			foreach($html->find('font[size=4]') as $element)
			{
				$i += 1;
				$t += 1;
				if ($i == 26)
				{
					$t = 25;
					continue;
				}
				
				$arrTitles[$t] =  iconv("windows-1251","utf-8",$element);
				
				
			}
			/*
			$arrSrc[39] = $arrSrc[38];
			$arrSrc[38] = $arrSrc[37];
			$arrSrc[37] = $arrSrc[36];
			*/
		?>
		
		<table border="1" width="65%" align="center">
			<?php
			
				for($j = 1; $j < $i; $j++)
				{
					echo "
						<tr>
							<td width=\"160\"><img width=\"150\" vspace=\"5\" border=\"0\" align=\"center\" src=" . $arrSrc[$j] . "></td>
							<td align=\"center\">" . $arrTitles[$j] . "</td>
						<tr>
					";					
				}
			?>
		</table>
	
	</body>
</html>