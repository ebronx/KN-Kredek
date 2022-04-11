const tacoElement = document.getElementById('taco');
const spinElement = document.getElementById('spin');
const speedElement = document.getElementById('internal-speed');
const timeElement = document.getElementById('time');
const addButtonElement = document.getElementById('add');
const subButtonElement = document.getElementById('sub');
const messageElement = document.getElementById('message');
const containerElement = document.getElementById('container-element');

tacoElement.addEventListener('click',rotate);
subButtonElement.addEventListener('click',subSpeed);
addButtonElement.addEventListener('click',addSpeed);


let canRotate = false;
let intervalSpeed = 20;
let degree = 0;
let spin = 0;

const messages = [
    'You really like tacos!',
    'Holy spinning taco!',
    'You dont fool around.',
    'Uhhh... taco spin master?',
    'Nobody likes tacos more than you.',
    'Time for you to open a taco shop.'
];

function rotate(){
    canRotate = !canRotate;
    console.log(canRotate);
}

let myInterval = setInterval(tacoTimer,intervalSpeed)
setInterval(myTimer,1000);

function tacoTimer(){
    if(canRotate){
        degree += 5;
        if(degree >355){
            degree =0;
            spin++;
            spinElement.innerHTML = spin;
        }
        if(spin % 3 === 0){
        randomMessage();
        }
        tacoElement.style.transform = 'rotate(' + degree +'deg)';
    }
}

function randomMessage(){
    const number = Math.floor(Math.random() * messages.length);
    messageElement.innerHTML = message[number];
    const color = Math.floor(Math.random() * 16777215).toString(16);
    containerElement.style.backgroundColor = '#' + color;
}

function addSpeed(){
    intervalSpeed++;
    console.log(intervalSpeed);
    clearInterval(myInterval);
    myInterval=setInterval(tacoTimer,intervalSpeed);
    speedElement.innerHTML=intervalSpeed;
}

function subSpeed(){
    intervalSpeed--;
    console.log(intervalSpeed);
    clearInterval(myInterval);
    myInterval=setInterval(tacoTimer,intervalSpeed);
    speedElement.innerHTML=intervalSpeed;
}

function load(){
    const date = new Date();
    timeElement.innerHTML = date.toLocalTimeString();
    spinElement.innerHTML = spin;
    speedElement.innerHTML = intervalSpeed;
    messageElement.innerHTML="jeszcze sie wgrywam";
    randomMessage();
}
function myTimer(){
    const date = new Date();
    timeElement.innerHTML= data.toLocalTimeString();
}

window.onload = load;