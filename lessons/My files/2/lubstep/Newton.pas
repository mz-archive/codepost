{Метод Ньютона решения нелинейного уравнения}
program Newton;
uses crt;

function f(x:real):real; {Исходная функция}
begin
 f:=6*sqr(x)+4*x-1;
end;

function f1(x:real):real; {Первая производная функции}
begin
 f1:=12*x+4;
end;

var a,b,x,e,en:real;
    i:integer;

begin
 clrscr; {очистить экран}
 writeln ('Решение нелинейного уравнения методом Ньютона');
 write ('Введите левую и правую границы интервала:');
 read (a,b);
 write ('Введите требуемую точность решения:');
 read (e);
 writeln ('Решение:');
 writeln ('Номер шага Значение X');
 en:=abs(a-b);
 x:=b;
 i:=1;
 while (abs(en)>e) do begin {Пока не достигнута точность}
  x:=x-f(x)/f1(x); {выполнить шаг метода}
  writeln (i:10,x:20:14); {вывести значение X с шага}
  en:=abs(x-b); {Новая точность}
  b:=x; {Значение границы для следующего шага}
  i:=i+1; {Номер шага}
 end;
end.