// Swiper: Slider
new Swiper('.swiper-container', {
	loop: true,
	nextButton: '.swiper-button-next',
	prevButton: '.swiper-button-prev',
	slidesPerView: 2,
	paginationClickable: true,
	spaceBetween: 440,
	breakpoints: {
		1920: {
			slidesPerView: 2,
			spaceBetween: 440,
		},
		1820: {
			slidesPerView: 2,
			spaceBetween: 350,
		},
		1720: {
			slidesPerView: 2,
			spaceBetween: 300,
		},

		1620: {
			slidesPerView: 2,
			spaceBetween: 250,
		},

		1520: {
			slidesPerView: 2,
			spaceBetween: 200,
		},

		1420: {
			slidesPerView: 2,
			spaceBetween: 150,
		},
		1320: {
			slidesPerView: 2,
			spaceBetween: 100,
		},
		1220: {
			slidesPerView: 2,
			spaceBetween: 70,
		},
		1120: {
			slidesPerView: 2,
			spaceBetween: 50,
		},
		1024: {
			slidesPerView: 2,
			spaceBetween: 120,
		},
		689: {
			slidesPerView: 1,
			spaceBetween: 5,
		},
	},
});

//일정시간마다 배경이 바뀌는 스크립트
const imgArray = [
	'smartHomeBg1.png',
	'smartHomeBg2.png',
	'smartHomeBg3.png',
	'smartHomeBg4.png',
	'smartHomeBg5.png',
	'smartHomeBg6.png',
];

function showImage() {
	const imgNum = Math.floor(Math.random() * imgArray.length);
	const objImg = document.getElementById('smartHome');
	objImg.style.backgroundImage = `url(img/${imgArray[imgNum]})`;

	setTimeout(showImage, 4500);
}

showImage();
