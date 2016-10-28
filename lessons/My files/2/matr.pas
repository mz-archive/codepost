Program Dvmas;
uses crt;
var i,j,k,n,m,i2,i3:integer;
matr:array [1..20, 1..20] of integer;
matr2:array [1..20, 1..20] of integer;
mres:array [1..20, 1..20] of integer;
BEGIN
 ClrScr;
 Write('”кажите рамерность 1-ой матрицы (2 числа через пробел) = ');
 ReadLn(j,k);
 Write('”кажите рамерность 2-ой матрицы = ');
 ReadLn(n,m);
 WriteLn('–езультирующа€ получитс€ ',j,' x ',m);
 {------------------------------------}
 TextColor(12);
 WriteLn('¬водим 1-ую матрицу');
 TextColor(2);
 For i:=1 to j do
 for i2:=1 to k do
 begin
 Write('matr[',i,',',i2,'] = ');
 ReadLn(matr[i,i2]);
 end;
{---------------------------------}
 TextColor(12);
 WriteLn('¬водим 2-ую матрицу');
 TextColor(2);
 For i:=1 to n do
 for i2:=1 to m do
 begin
 Write('matr2[',i,',',i2,'] = ');
 ReadLn(matr2[i,i2]);
 end;
{--------------------------------}

for i:=1 to j do
for i2:=1 to m do
begin
mres[i,i2]:=0;
for i3:=1 to k do
mres[i,i2]:=mres[i,i2] + matr[i,i3] * matr2[i3,i2];
end;
 {---------------------------------}
 WriteLn('–езультат:');

 For i:=1 to j do
 for i2:=1 to m do
 begin
 Writeln('mres[',i,',',i2,'] =',mres[i,i2]);
 end;

 
END.

