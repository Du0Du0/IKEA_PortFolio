const smartSection = document.querySelector('#smartHome');
const smartSlideContainer = smartSection.querySelector('.swiper-container');
const smartSlideWrap = smartSection.querySelector('.swiper-wrapper');

fetch('DB/smartHome.json')
	.then((res) => res.json())
	.then((data) => {
		const smartData = data.smartHome;
		let tags = '';

		smartData.forEach((data) => {
			tags += `
                <figure class="swiper-slide" >
                    <h4>${data.topic}</h4>
                    <h2>${data.title}</h2>
                    <span class="animation">${data.animation}</span>
                </figure>`;
		});

		smartSlideWrap.innerHTML = tags;

		const controlBtns = smartSection.querySelectorAll('.controlBtn');
		const smartBgs = smartSection.querySelectorAll('.smartBg');
		const swiperSlides = smartSection.querySelectorAll('.swiper-slide');
		const animation = smartSection.querySelectorAll('.animation');

		swiperSlides.forEach((swiperSlide, idx) => {
			swiperSlide.addEventListener('mouseenter', (e) => {
				e.preventDefault();
				smartBgs[idx].classList.add('on'); // smartBgs를 사용해야 함
				swiperSlides[idx].classList.add('on'); // smartBgs를 사용해야 함
				animation[idx].classList.add('movingText');
			});
		});

		// Swiper: Slider
		new Swiper('.first', {
			loop: true,
			nextButton: '.swiper-button-next',
			prevButton: '.swiper-button-prev',
			slidesPerView: 3,
			paginationClickable: true,
			spaceBetween: 180,
			breakpoints: {
				1920: {
					slidesPerView: 3,
					spaceBetween: 180,
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
	});
