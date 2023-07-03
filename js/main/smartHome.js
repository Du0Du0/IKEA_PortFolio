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
						<img class="smartBg " src = 'img/${data.picOn}'>
						<span class="animation">${data.animation}</span>
				</figure>`;
		});

		smartSlideWrap.innerHTML = tags;

		const controlBtns = smartSection.querySelectorAll('.controlBtn');
		const smartBgs = smartSection.querySelectorAll('.smartBg');
		const swiperSlides = smartSection.querySelectorAll('.swiper-slide');
		const animations = smartSection.querySelectorAll('.animation');

		for (var i = 0; i < animations.length; i++) {
			if (i % 2 === 0) {
				animations[i].style.bottom = '-72px';
				animations[i].style.left = '72px';
				animations[i].style.textAlign = 'left';
			} else {
				animations[i].style.bottom = '-72px';
				animations[i].style.right = '72px';
				animations[i].style.textAlign = 'right';
			}
		}

		swiperSlides.forEach((swiperSlide, idx) => {
			swiperSlide.addEventListener('mouseenter', (e) => {
				e.preventDefault();
				smartBgs[idx].classList.add('on');
				swiperSlides[idx].classList.add('on');

				if (idx % 2 === 0) {
					animations[idx].classList.add('movingTextOdd');
				} else {
					animations[idx].classList.add('movingTextEven');
				}
			});
		});

		//일정시간마다 배경이 바뀌는 스크립트
		const imgArray = ['smartHomeBg1.png', 'smartHomeBg2.png', 'smartHomeBg3.png', 'smartHomeBg4.png', 'smartHomeBg5.png', 'smartHomeBg6.png'];

		showImage();

		function showImage() {
			const imgNum = Math.floor(Math.random() * imgArray.length);
			smartSection.style.backgroundImage = `url(img/${imgArray[imgNum]})`;
			setTimeout(showImage, 5000);
		}

		swiperSlides.forEach((swiperSlide, idx) => {
			swiperSlide.addEventListener('mouseleave', (e) => {
				e.preventDefault();
				smartBgs[idx].classList.remove('on');
				swiperSlides[idx].classList.remove('on');
				animations[idx].classList.remove('movingTextOdd');
				animations[idx].classList.remove('movingTextEven');
			});
		});

		// Swiper: Slider
		new Swiper('.first', {
			loop: false,
			nextButton: '.swiper-button-next',
			prevButton: '.swiper-button-prev',
			paginationClickable: true,
			lazy: {
				loadPrevNext: true, // 이전, 다음 이미지는 미리 로딩
			},
			spaceBetween: 150,
			breakpoints: {
				1920: {
					slidesPerView: 3,
					spaceBetween: 150,
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
