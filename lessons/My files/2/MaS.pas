Program MaS;
uses crt;
var i,n,max,mIndex:integer;
    m: array [1..200] of integer;
BEGIN
     ClrScr;
     max:=0;
     Write('������� ��������� ������� ������� ������? = ');
     Readln(n);
     for i:=1 to n do
         begin
              Write('m[',i,'] = ');
              ReadLn(m[i]);
              If max < m[i] then
                 begin
                      max:=m[i];
                      mIndex:=i;
                 end;
         end;
     Writeln('-----------------------------------');
     Writeln('������������: m[',mIndex,'] = ',max);
     Writeln('-----------------------------------');
     for i:=mIndex+1 to n do
            begin
                 m[i]:=m[i]-1;
            end;
      Writeln('�������� ������:');
        for i:=1 to n do
            begin
                 Write(' mas[',i,'] = ',m[i]);
            end;
      ReadLn;
END.