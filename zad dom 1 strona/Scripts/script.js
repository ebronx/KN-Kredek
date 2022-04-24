setInterval(myTimer, 1000);

function myTimer() {
  const date = new Date();
  document.getElementById("zegar").innerHTML = date.toLocaleTimeString();
}