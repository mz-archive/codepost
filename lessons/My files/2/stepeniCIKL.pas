program stepeni;
Uses crt;
var i,n,k,ReZ:integer;
    h:real;

BEGIN
clrscr;
       ReZ:=1;
       Write('������� ����� = ');
       Readln(k);
       Write('������� �������� ����� ����� �������? = ');
       Readln(n);

       for i:=1 to n do

           begin
                ReZ:=ReZ * k;
                Writeln(k,' � ',i,'-�� = ',ReZ);
           end;

       Readln;
END.
