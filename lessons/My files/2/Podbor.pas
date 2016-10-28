Program podbor;
uses crt;
var z,i,count:integer;
    a,b,c,x,n,j:Real;
Begin
  ClrScr;
  count:=1;
Writeln('–ешение уравнени€ типа Ax^z+Bx+C=0');
Write('a=');
ReadLn(a);
Write('b=');
ReadLn(b);
Write('c=');
ReadLn(c);
Write('z=');
ReadLn(z);
Write('¬ведите границы через пробел = ');
ReadLn(x,n);
while x < n do
begin
x:=x+0.1;
j:=x;
for i:=1 to z do
    begin
     j:=j*j;
    end;
  if round(a*j+b*x+c)=0 then
  begin
  Writeln('x',count,'=',x);
  inc(count);
  end;
end;
ReadKey;
END.