
const myTimeout = setTimeout(myGreeting, 2000);

function myGreeting() {
  document.getElementById("greeting").innerHTML = "Zapraszamy pod ponizsze linki!"
}

document.getElementById("odsluchaneButton").addEventListener("click", function() {
  alert("Gratulujemy nabycia nowej wiedzy!");
});