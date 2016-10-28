Program ENRU;
Uses crt;
var f:char;
    symbol:byte;
    flag:boolean;
BEGIN
  ClrScr;
         Repeat
               Write('Введите фамилию = ');
               ReadLn(f);
               symbol:=Ord(f);
               if symbol < 122 then
                  begin
                   gotoxy(wherex,wherey-1);
                   delline;
                   Writeln('Вы ввели фамилию на английском языке! Введите на руском!');
                  end else
                      begin
                        WriteLn('Фамилия введена правильно!');
                        flag:=true;
                      end;
         Until flag;

END.
