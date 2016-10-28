program bukvi;
Uses crt;
var n,i,x:longint;
    h:real;
BEGIN
     clrscr;
     Writeln('Сколько степеней выводить');
     Readln(n);
     Writeln('Степень какого числа выводить?');
     Readln(x);

     for i:=1 to n do

         begin
         TextColor(12);
         h:=exp(ln(x)*i);
         Writeln(x,' в ',i,' -ой = ',h:0:1);
         end;
         
         Readln;
     end.


         
