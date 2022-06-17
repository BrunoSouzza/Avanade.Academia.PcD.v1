�
mC:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Api\Controllers\WeatherForecastController.cs
	namespace 	
Avanade
 
. 
Academia 
. 
PcD 
. 
Api "
." #
Controllers# .
{ 
[ 

] 
[ 
Route 

(
 
$str 
) 
] 
public 

class %
WeatherForecastController *
:+ ,
ControllerBase- ;
{ 
private

 
readonly

 
ILogger

  
<

  !%
WeatherForecastController

! :
>

: ;
_logger

< C
;

C D
public %
WeatherForecastController (
(( )
ILogger) 0
<0 1%
WeatherForecastController1 J
>J K
loggerL R
)R S
{
_logger 
= 
logger 
; 
} 	
} 
} �
OC:\Proj\Eventos\Avanade.Academia.PcD.v1\src\Avanade.Academia.PcD.Api\Program.cs
var 
builder 
= 
WebApplication 
. 

(* +
args+ /
)/ 0
;0 1
builder 
. 
Services 
. 
AddControllers 
(  
)  !
;! "
builder 
. 
Services 
. #
AddEndpointsApiExplorer (
(( )
)) *
;* +
builder 
. 
Services 
. 

( 
)  
;  !
var

 
app

 
=

 	
builder


 
.

 
Build

 
(

 
)

 
;

 
if
(
app
.
Environment
.

(
)
)
{ 
app 
. 

UseSwagger 
( 
) 
; 
app 
. 
UseSwaggerUI 
( 
) 
; 
} 
app 
. 
UseHttpsRedirection 
( 
) 
; 
app 
. 
UseAuthorization 
( 
) 
; 
app 
. 
MapControllers 
( 
) 
; 
app 
. 
Run 
( 
) 	
;	 