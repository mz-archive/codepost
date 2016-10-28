program koren;
Uses crt;
var a,b,c:integer;
x1,x2,D:real;
BEGIN
clrscr;
     Writeln('Введите a b c ');
     Readln(a,b,c);
     D:= sqr(b) - 4 * a *c;
     if D<0 then
     begin
        Writeln('D<0 Нет корней!');
     end;

     if D=0 then

     begin
         Writeln('D=0 есть 1 корень!');
         x1:=(-b+sqrt(D))/2*a;
         Writeln('x1 =',x1)
     end;

     if D>0 then
     
     begin
          Writeln('D>0 2 корня!');
          x1:=(-b+sqrt(D))/2*a;
          x1:=(-b-sqrt(D))/2*a;
          Writeln('x1 =',x1:0:1,' x2=',x2:0:1);
     end;
     Readln;
     end.


