<?php 

    require_once('parse-lib/PHPExcel.php');

    $xls = PHPExcel_IOFactory::load('ППС_201516_на_сайт.xls');
    $sheet = $xls->getActiveSheet();

    $nColumn = PHPExcel_Cell::columnIndexFromString($sheet->getHighestColumn());
    
    $nRow = $sheet->getHighestRow();

    $arr_dolg = []; 
    $arr_fio = [];
    $arr_step = [];
    $arr_zvan = [];
    $arr_st_all = [];
    $arr_st = [];
    $arr_naprav = [];
    $arr_discip = [];
    $arr_uroven = [];
    $arr_prog = [];
    $arr_year = [];


    for ($j=3; $j < $nRow; $j++) { 
        
        for ($i=0; $i < $nColumn; $i++) { 
            $value = $sheet->getCellByColumnAndRow($i, $j)->getValue();

            /*if ($i == 1){

                echo "

                        <table border=\"1\">
                           <tr><td>{$value}</td></tr>
                    ";
            }

            if ($i == 0) echo "<tr><td>{$value}</td></tr></table>";*/

            if ($i == 0) $arr_fio[] = $value;
            if ($i == 1) $arr_dolg[] = $value;
            if ($i == 2) $arr_uroven[] = $value;
            if ($i == 3) $arr_step[] = $value;
            if ($i == 4) $arr_zvan[] = $value;
            if ($i == 5) $arr_prog[] = $value;
            if ($i == 6) $arr_year[] = $value;
            if ($i == 7) $arr_st_all[] = $value;
            if ($i == 8) $arr_st[] = $value;
            if ($i == 9) $arr_naprav[] = $value;
            if ($i == 10) $arr_discip[] = $value;



        }
    }

    echo "<meta charset='utf-8'>";
    echo "<table>";


    for ($k=0; $k < $nRow; $k++) {


    echo ($arr_dolg[$k] == "" ? "":"<tr><td><p style='color: #FF0000;'><span itemprop=\"Post\">{$arr_dolg[$k]}</span></p></td></tr>"); 
    echo ($arr_fio[$k] == "" ? "":"<tr><td><b>ФИО: <span itemprop=\"fio\">{$arr_fio[$k]}</span></b></td></tr>"); 
    echo ($arr_uroven[$k] == "" ? "":"<tr><td><span style='color: #0000FF;'>Уровень образования:</span> {$arr_uroven[$k]}</td></tr>"); 
    echo ($arr_step[$k] == "" ? "":"<tr><td><span style='color: #0000FF;'>Ученая степень:</span> <span itemprop=\"Degree\">{$arr_step[$k]}</span></td></tr>"); 
    echo ($arr_zvan[$k] == "" ? "":"<tr><td><span style='color: #0000FF;'>Ученое звание:</span> <span itemprop=\"AcademStat\">{$arr_zvan[$k]}</span></td></tr>"); 
    echo ($arr_prog[$k] == "" ? "":"<tr><td><span style='color: #0000FF;'>Квалификация:</span> <span itemprop=\"ProfDevelopment\">{$arr_prog[$k]} -  {$arr_year[$k]}</span></td></tr>"); 
    echo ($arr_st_all[$k] == "" ? "":"<tr><td><span style='color: #0000FF;'>Стаж общий:</span> <span itemprop=\"GenExperience\">{$arr_st_all[$k]}</span></td></tr>"); 
    echo ($arr_st[$k] == "" ? "":"<tr><td><span style='color: #0000FF;'>Стаж педагогический:</span> <span itemprop=\"SpecExperience\">{$arr_st[$k]}</span></td></tr>"); 
    echo ($arr_naprav[$k] == "" ? "":"<tr><td><span style='color: #0000FF;'>Направление подготовки:</span> <span itemprop=\"EmployeeQualification\">{$arr_naprav[$k]}</span></td></tr>"); 
    echo ($arr_discip[$k] == "" ? "":"<tr><td><span style='color: #0000FF;'>Дисциплина:</span> <span itemprop=\"TeachingDiscipline\">{$arr_discip[$k]}</span></td></tr>");
        
        /*echo "
                    <tr><td><p style='color: #FF0000;'><span itemprop=\"Post\">{$arr_dolg[$k]}</span></p></td></tr>
                    2<tr><td><b>ФИО: <span itemprop=\"fio\">{$arr_fio[$k]}</span></b></td></tr>
                    3<tr><td><span style='color: #0000FF;'>Уровень образования:</span> {$arr_uroven[$k]}</td></tr>
                    4<tr><td><span style='color: #0000FF;'>Ученая степень:</span> <span itemprop=\"Degree\">{$arr_step[$k]}</span></td></tr>
                    <tr><td><span style='color: #0000FF;'>Ученое звание:</span> <span itemprop=\"AcademStat\">{$arr_zvan[$k]}</span></td></tr>
                    <tr><td><span style='color: #0000FF;'>Квалификация:</span> <span itemprop=\"ProfDevelopment\">{$arr_prog[$k]} -  {$arr_year[$k]}</span></td></tr>
                    <tr><td><span style='color: #0000FF;'>Стаж общий:</span> <span itemprop=\"GenExperience\">{$arr_st_all[$k]}</span></td></tr>
                    <tr><td><span style='color: #0000FF;'>Стаж педагогический:</span> <span itemprop=\"SpecExperience\">{$arr_st[$k]}</span></td></tr>
                    <tr><td><span style='color: #0000FF;'>Направление подготовки:</span> <span itemprop=\"EmployeeQualification\">{$arr_naprav[$k]}</span></td></tr>
                    <tr><td><span style='color: #0000FF;'>Дисциплина:</span> <span itemprop=\"TeachingDiscipline\">{$arr_discip[$k]}</span></td></tr>
             ";*/
    
    }
    echo "</table>";

 ?>