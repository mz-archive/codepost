program fact;
Uses crt;
var i,n,z:integer;
Begin
clrscr;
z:=1;
       Writeln('Факториал какого числа найти?');
       Readln(n);
       
       for i:=1 to n do
       begin
            z:=z * i;
       end;
       if z = 0 then Writeln (n,'! = 0') else
       Writeln(n,'! = ',z);
       Readln;
END.

