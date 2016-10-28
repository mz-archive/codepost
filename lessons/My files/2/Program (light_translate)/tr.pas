program light_translate;
uses crt;
var ru_c,en_c,i,k:integer;
    f:text;
    slovo,s:string;
    ru:array [1..300] of string;
    en:array [1..300] of string;
    finish:boolean;
{---------------------------------------------}	
procedure russian;
  begin
 TextColor(12);
  Write('Введите слово на английском: ');
   ReadLn(slovo);
   for i:=1 to pred(ru_c) do
   begin
    if slovo = en[i] then
    begin
    TextColor(9);
    WriteLn('Перевод: ',ru[i]);
    end;
   end;
   ReadLn;
  end;
{---------------------------------------------}  
procedure english;
  begin
  TextColor(12);
   Write('Введите слово на русском: ');
   ReadLn(slovo);
   for i:=1 to pred(ru_c) do
   begin
    if slovo = ru[i] then
    begin
    TextColor(9);
    WriteLn('Перевод: ',en[i]);
    end;
   end;
   ReadLn;
  end;
{---------------------------------------------}
BEGIN
	ClrScr;
	ru_c:=1;
	en_c:=1;
	Assign(f,'Slova.txt');
	{-------------------------------------------------}
	Reset(f);
	while not(eof(f)) do
		begin
			readln(f,s);
			inc(i);
			if odd(i) then
			   begin
				   ru[ru_c]:=s;
				   inc(ru_c);
			   end
			else
				begin
					en[en_c]:=s;
					inc(en_c);
				end;
		end;
	Close(f);
	{--------------------------------------------------}
	Repeat
		ClrScr;
		TextColor(0);
		WriteLn('ПЕРЕВОД СЛОВ ИЗ СЛОВАРЯ!');
		WriteLn('1 - Перевод слова на русский');
		WriteLn('2 - Перевод слова на английский');
		WriteLn('0 - Выйти из программы');
		Case ReadKey of
			#49:russian;
			#50:english;
			#48:finish:=true;
		end;
	Until finish;



END.