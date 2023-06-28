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

/*
window.scrollY : 브라우저의 스크롤 거리값 반환 (동적)
DOM.offsetTop : 해당돔요소의 세로 위치값 반환 (정적)
window.scrollTo({left: 가로스크롤 위치값, top: 세로스크롤 위치값}) : 해당 위치값으로 스크롤 이동
*/

const boxes = document.querySelectorAll('.box1');
const circles = document.querySelectorAll('.circle');

// Depending on screen size how much the circles will grow?

window.addEventListener('scroll', () => {
	const scrollY = window.scrollY - 450;
	boxes.forEach((circle) => {
		circle.style.clipPath = `circle(${scrollY}px at center)`;
	});

	// 스크롤하면 배경색 바뀌는 기능

	const changeColorTxt = membersSection.querySelectorAll('.tile h3, .tile h2, .tile h4, .tile p');

	window.addEventListener('scroll', () => {
		console.log(window.scrollY);

		//첫번째 article 영역 스크롤 배경색 바뀌는 기능
		if (window.scrollY > 5000) {
			document.body.style.transition = '0.3s';
			document.body.style.background = '#fedc01';
		} else if (window.scrollY < 5000) {
			document.body.style.background = '#fff';
		}

		//두번째 article 영역 스크롤 배경색 바뀌는 기능
		if (window.scrollY > 8100) {
			document.body.style.transition = '0.3s';
			document.body.style.background = '#090909';
			changeColorTxt.forEach((element) => {
				element.style.color = '#969696';
			});
		} else if (window.scrollY < 8100) {
			changeColorTxt.forEach((element) => {
				element.style.color = '#333';
			});
		}

		//세번째 article 영역 스크롤 배경색 바뀌는 기능
		if (window.scrollY > 11000) {
			document.body.style.transition = '0.3s';
			document.body.style.background = '#0058ab';
			changeColorTxt.forEach((element) => {
				element.style.color = '#eee';
			});
		} else return;

		//네번째 article 영역 스크롤 배경색 바뀌는 기능
		if (window.scrollY > 13000) {
			document.body.style.transition = '0.3s';
			document.body.style.background = '#fff';
			changeColorTxt.forEach((element) => {
				element.style.color = '#333';
			});
		} else return;
	});
});

//슬라이더
let currentSlide = 0;

const slides = document.querySelectorAll('.slider .slide');
const totalSlides = slides.length;

// Hides all slides, Displays Current index
function cycleSlides() {
	const slide = slides[currentSlide];
	slides.forEach((slide) => {
		slide.style.display = 'none';
	});
	slide.style.display = 'inline-block';
}

document.querySelector('.next').addEventListener('click', function () {
	currentSlide += 1;

	if (currentSlide > totalSlides - 1) {
		currentSlide = 0;
	}
	cycleSlides();
});

document.querySelector('.prev').addEventListener('click', function () {
	currentSlide -= 1;

	if (currentSlide < 0) {
		currentSlide = totalSlides - 1;
	}

	cycleSlides();
});
