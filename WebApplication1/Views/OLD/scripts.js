

/* Toggle between showing and hiding the navigation menu links when the user clicks on the hamburger menu / bar icon */
function topNavMobile() {

    alert('hello')
    var arrayOfNav = document.getElementsByClassName("navTop")
    if (true) {
        arrayOfNav.forEach(a=>a.style.display= "block")
        alert('visible')
    } else {
        alert('in')
        for(var i = 0; i < arrayOfNav.length; i++) {
            alert(i);
            arrayofNav[i].style.display = "block"
        }
        alert('Found!')
    }
    alert('Finish.')
}