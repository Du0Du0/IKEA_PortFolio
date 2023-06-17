const membersSection = document.querySelector('.members');
const memberBoxContainer = membersSection.querySelector('.memberBoxContainer');

let tags = '';

fetch('DB/members.json')
	.then((res) => res.json())
	.then((json) => {
		console.log(json.item);
		const membersData = json.members;

		membersData.map((data) => {
			tags += `
       <div class="membersBox">
       <div class="membersName"><h1>${data.name}</h1><h3>${data.sub}</h3></div>
        <div class="membersImg" style="background-image : url(img/${data.pic})"><div class="colorBg">1</div></div>
        <div class="membersDesc"><p>${data.description}</p></div>

     </div>
      `;
		});
		memberBoxContainer.innerHTML = tags;
	});

//슬라이더

// Variables

// Set index to 0
let currentSlide = 0;
// Store all slides
const slides = document.querySelectorAll('.slider .slide');
// Store total number of slides
const totalSlides = slides.length;

// Functions
// ----------------------------

// Hides all slides, Displays Current index
function cycleSlides() {
	// stores current slide
	const slide = slides[currentSlide];
	// hides all slides
	slides.forEach((slide) => {
		slide.style.display = 'none';
	});
	// display current slide
	slide.style.display = 'inline-block';
}

// call click function when next button is clicked
document.querySelector('.next').addEventListener('click', function () {
	// update current slide index
	currentSlide += 1;
	// if on last slide, reset index to 0
	if (currentSlide > totalSlides - 1) {
		currentSlide = 0;
	}
	// run cycle slides function to display slide
	cycleSlides();
});

// call click function when prev button is clicked
document.querySelector('.prev').addEventListener('click', function () {
	// update current slide index
	currentSlide -= 1;
	// if on first slide, move to last slide
	if (currentSlide < 0) {
		currentSlide = totalSlides - 1;
	}
	// run cycle slides function to display slide
	cycleSlides();
});
