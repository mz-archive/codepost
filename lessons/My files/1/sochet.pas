program factproc;
Uses crt;
var i,z,x,l,g,y:integer;
    A:real;
procedure fact (n,m:integer);
begin
 z:=1;
 
     for i:=1 to n do     {факториал n}
     begin
       z:=z * i;
     end;

     l:=n-m;
     g:=1;
     
     for i:=1 to l do {факториал n-m}
     begin
       g:=g * i;
     end;

     y:=1;
     
     for i:=1 to m do   {факториал m}
     begin
       y:=y * i;
     end;
     
     A:=z/(y*g);  {результат}
end;
BEGIN
clrscr;
        fact(8,2);  {передаваемые значения n,m}
        Writeln(A:0:0);    {форматированный вывод результата}
Readln;
END.
