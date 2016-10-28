Program metod_prostyh_iteraciy;
uses crt;
var x1,x0,eps:real; i:integer;
function f(x:real):real;
{Oписание функции}
begin
 f:=2*x-cos(x);
end;
{Описание функциии fi(x) для итерационного
уравнения x=fi(x)}
function fi(x:real):real;
begin
 fi:=cos(x)/2;
end;

{Описание метода итераций}
function iterac(var x0,e:real):real;
var n:integer;delta:real;
begin
 n:=0;
 writeln('Промежуточныe значения метода итераций');
 repeat
 delta:=abs(x0-fi(x0));
 write('x', n:1, ' = ',x0:8:5,' fi(x',n:1, ')=',
 fi(x0):8:5,' eps=',delta:8:5);
 x0:=fi(x0);
 n:=n+1; readln;
 until (delta<e) or (n>300);
 writeln('Число итераций =',n);
 iterac:= x0;
end;

begin
 clrscr;
 write('Начальное значение корня = ');readln(x0);
 write('Точность вычисления корня = ');readln(eps);
 x1:=iterac(x0,eps);
 writeln('Приближенное значение корня с точностью ',eps:7:5);
 writeln('x = ',x1:8:6);
 readln;
end.