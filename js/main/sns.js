// Swiper: Slider
new Swiper('.swiper-container', {
	loop: true,
	nextButton: '.swiper-button-next',
	prevButton: '.swiper-button-prev',
	slidesPerView: 2,
	paginationClickable: true,
	spaceBetween: 400,
	breakpoints: {
		1920: {
			slidesPerView: 2,
			spaceBetween: 400,
		},
		1820: {
			slidesPerView: 2,
			spaceBetween: 350,
		},
		1720: {
			slidesPerView: 2,
			spaceBetween: 200,
		},

		1620: {
			slidesPerView: 2,
			spaceBetween: 150,
		},

		1520: {
			slidesPerView: 2,
			spaceBetween: 35,
		},
		1024: {
			slidesPerView: 2,
			spaceBetween: 30,
		},
		689: {
			slidesPerView: 1,
			spaceBetween: 10,
		},
	},
});
