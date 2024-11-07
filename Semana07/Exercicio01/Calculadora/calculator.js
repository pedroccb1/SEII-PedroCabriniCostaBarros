var value;
var result;
function button(num){
    value = document.calc.visor.value += num;
}
function reset(){
    document.cal.visor = '';
}
function solve(){
    result = eval(value);
    document.calc.visor.value = result.toLocaleString('pt-Br');
}