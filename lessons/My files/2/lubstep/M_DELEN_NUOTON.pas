program dn1;
uses
  crt;
const
  E = 0.000001;
var
  a, b, x : real;
function f(x:real):real;
begin
  f := x*sin(pi/12*x-pi/3)-2.13;
end;
function f1(x:real):real;
begin
  f1 := sin(pi/12*x-pi/3) + x*pi/12*cos(pi/12*x-pi/3);
end;
begin
  clrscr;
  a := -4; b := -1;
  repeat
    x := (a+b)/2;
    if f(a)*f(x)<=0 then b := x
    else a := x;
  until abs(b-a)<E;
  x := (a+b)/2;
  writeln('Метод половинного деления : ');
  writeln('x = ',x:0:12);
  writeln('f(x) = ',f(x):0:12);
  a := -4; b := -1;
  if f(a)*f1(a)>0 then x := a
  else x := b;
  while abs(f(x))>E do
    x := x - f(x)/f1(x);
  writeln('Метод Ньютона (касательных) : ');
  writeln('x = ',x:0:12);
  writeln('f(x) = ',f(x):0:12);
  readln;
end.