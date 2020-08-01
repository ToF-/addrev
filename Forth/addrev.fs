\ reverse the number on the stack
\ 4807 -- 7084
\ 1400 -- 41
: REVERSE 
    0 SWAP
    BEGIN
        10 /MOD 
        ROT 10 *
        ROT +
        SWAP
    ?DUP 0= UNTIL ;

: READLN ( -- addr,l )
    PAD DUP 40 
    STDIN READ-LINE THROW
    DROP ;

: READ-NUMBERS ( -- n,m,.. )
    READLN EVALUATE ;

: MAIN
    READ-NUMBERS
    0 DO
        READ-NUMBERS
        REVERSE SWAP REVERSE + REVERSE
        . CR
    LOOP ;
    
MAIN BYE
