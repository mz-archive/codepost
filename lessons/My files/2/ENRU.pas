Program ENRU;
Uses crt;
var f:char;
    symbol:byte;
    flag:boolean;
BEGIN
  ClrScr;
         Repeat
               Write('������� ������� = ');
               ReadLn(f);
               symbol:=Ord(f);
               if symbol < 122 then
                  begin
                   gotoxy(wherex,wherey-1);
                   delline;
                   Writeln('�� ����� ������� �� ���������� �����! ������� �� ������!');
                  end else
                      begin
                        WriteLn('������� ������� ���������!');
                        flag:=true;
                      end;
         Until flag;

END.
