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
BEGIN
  ClrScr;
  Assign(list,'F:\ГУ\2 курс\алгоритмизация\list_stud.txt');
  
  
