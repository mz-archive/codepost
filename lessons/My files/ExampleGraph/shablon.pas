program shablon;
Uses crt, GraphABC;
var GraphDriver, GraphMode:integer;

BEGIN
ClrScr;
       GraphDriver:=detect;
       InitGraph(GraphDriver, GraphMode, '');
       
       Readln;
       CloseGraph;
END.