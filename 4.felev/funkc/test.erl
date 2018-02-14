-module(test).
-export([f/1,szamol/2]).

f(X) ->
  A = X + 2,
  A.

szamol(X,Y) ->
io:format("~w+~w=~w~n",[X,Y,X+Y]).
