program bukvi;
Uses crt;
var n,i,x:integer;
    h:real;
BEGIN
     clrscr;
     Writeln('Сколько степеней выводить');
     Readln(n);
     Writeln('Степень какого числа выводить?');
     Readln(x);

     Repeat
      inc(i);
         begin
         TextColor(12);
         h:=exp(ln(x)*i);
         Writeln(x,' в ',i,' -ой = ',h:0:1);
         end;
      UNTIL (i=n);
         Readln;
     end.


         
