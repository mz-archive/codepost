Program kvur;
uses crt;
var z,k,p,j,x:real;
BEGIN
     ClrScr;
     WriteLn('Программа решает уравнение вида a*x^2+b*x+c');
     WriteLn('Введите A,B,C ');
     readln(z,k,p);
     j:=sqr(k)-4*z*p;
     if j<0 then
        begin
          WriteLn('Действительных корней нет');
        end
     else if j = 0 then
        begin
          x:=(-k)/(2*z);
          WriteLn('Корень уравнения один D=0 он равнен = ',x:0:2);
        end
     else
         begin
           x:=(-k+sqrt(j))/(2*z);
           WriteLn('D>0');
           WriteLn('x1 = ',x:0:2);
           x:=(-k-sqrt(j))/(2*z);
           WriteLn('x2 = ',x:0:2);
         end;
     ReadLn;
END.

