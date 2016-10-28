program stepeni;
Uses crt;
var i,n,k,ReZ:integer;
    h:real;

BEGIN
clrscr;
       ReZ:=1;
       Write('¬ведите число = ');
       Readln(k);
       Write('—колько степеней этого числа вывести? = ');
       Readln(n);

       for i:=1 to n do

           begin
                ReZ:=ReZ * k;
                Writeln(k,' в ',i,'-ой = ',ReZ);
           end;

       Readln;
END.
