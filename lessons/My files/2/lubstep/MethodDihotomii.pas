Program Dihotom;
uses crt;
function F(x:real):real;
begin
F:=6*(sqr(x))+4*x-1;
end;

var a,b,c,x,e:real;
    k:integer;
begin
clrscr;
a:=0;
b:=2;
write('Введите точность вычислений e=');
readln(e);
k:=round(ln(1/e)/ln(10));
writeln('Решение уравнения x^3-x-1=0');
writeln('на интервале [',a:0:1,';',b:0:1,'] с погрешностью ',e:0:k);
repeat
   c:=(a+b)/2;
   if F(a)*F(c)<=0 then b:=c
   else a:=c;
until abs(b-a)<e;
x:=(a+b)/2;
writeln('x=',x:0:k);
readln;
end.
