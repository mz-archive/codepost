Program Otlov;
uses crt;
var i,n,m:integer;
    mas: array [1..250] of integer;

BEGIN
ClrScr;
Randomize;
          Writeln('����� ����������� ������ ��������� (��������! �� ������ 250!)');
          Readln(n);
          m:=0;  {�������������, �� ����������}

          Repeat
                inc(i);
                mas[i]:=random(21)-10;
                if ( odd(i) ) and ( mas[i] mod 2 = 0 ) then
                m:=m+mas[i];
                Writeln('mas[',i,'] = ',mas[i]);
          Until(i = n);

TextColor(2);
Writeln('-------------------------------------------');
TextColor(1);
Writeln('����� ��������� = ',m);
TextColor(2);
Writeln('-------------------------------------------');
Readln;
END.

