Program sortPuz;
uses crt;
const n = 4;
var a:array [1..n] of integer;
    i,j,x:integer;
BEGIN
  ClrScr;
  WriteLn('¬ведите ',n,'  элементов массива (они отсортируютс€ по возрастанию)');
  for i:=1 to n do
   ReadLn(a[i]);
  for i:=1 to n-1 do
      begin
        for j:=i+1 to n do
         begin
          if a[i] > a[j] then
            begin
              x:=a[i];
              a[i]:=a[j];
              a[j]:=x;
            end;
         end;
      end;
  WriteLn('после сортировки:');
  for i:=1 to n do
   WriteLn(a[i]);
END.
