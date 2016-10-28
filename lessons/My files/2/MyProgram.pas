program MyProgram;
uses crt;
type TextFile = text;
type z = Record
     id:integer;
     stud:string;
     number:integer;
     dom_num:integer;
     yl:string;
end;
var  student:array [1..1000] of z;
     i,m,n:Integer;
     list:TextFile;
     key:char;
     v:boolean;
Label met;
BEGIN
  ClrScr;
  Assign(list,'F:\\ГУ\2 курс\алгоритмизация\list_stud.txt');
  Repeat
  Writeln('Нажмите 1 если хотите добавить записи');
  Writeln('Нажмите 2 если хотите вывести записи');
  Writeln('Нажмите 3 если хотите удалить записи');
  Writeln('Нажмите 0 если хотите удалить записи');
  case ReadKey of
       #48:
           begin
            Goto met;
           end;
       #49:
           begin
             ReWrite(list);
             WriteLn('Сколько записей добавить?');
             Read(n);
             WriteLn('Введите через пробел <имя, номер телефона, номер дома, улицу>');
             for i:=1 to n do
                 begin
                   WriteLn('Введите ',i,'-ую запись');
                   ReadLn(list, student[i].stud, student[i].number, student[i].dom_num, student[i].yl);
                   WriteLn(list, student[i].stud, student[i].number, student[i].dom_num, student[i].yl);
                 end;
             close(list);
           end;

  end;
  Until v;
met:
WriteLn('Конец');
ReadLn;
END.
