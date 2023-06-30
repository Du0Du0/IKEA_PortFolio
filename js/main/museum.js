const museum = document.querySelector('#museum');
const swiperWrapper = museum.querySelector('.swiper-wrapper');

let tags = '';

fetch('DB/museum.json')
	.then((res) => res.json())
	.then((data) => {
		const museumData = data.museum;

		museumData.map((data) => {
			const tit = data.title;
			const con = data.content;
			tags += `
     <div class="swiper-slide">
				<h3>${data.topic}</h3>
				<h2>${tit.length > 7 ? tit.split(' ').splice(0, 7).join(' ') : tit}</h2>
				<p class="con">${con.length > 10 ? con.split(' ').splice(0, 10).join(' ') + '...' : con}
				</p>
				<p class="date">${data.date}&nbsp;&nbsp;| &nbsp;&nbsp;Exhibition</p>
			</div>
        `;
		});
		swiperWrapper.innerHTML = tags;

		const leftTxt = museum.querySelector('.leftTxt');
		const rightTxt = museum.querySelector('.rightTxt');
		const prevBtn = museum.querySelector('.swiper-button-prev');
		const nextBtn = museum.querySelector('.swiper-button-next');

		const titleLists = ['MÄVINN', 'Hej Ingvar', 'Our Roots', 'Democratic Design', 'Us & Our Planet', 'Story of IKEA', 'Existence Maximum'];

		let currentIdx = 0;
		let clickable = true;
		//이전 버튼 누르면 이전 목록 뜨게 하기
		prevBtn.addEventListener('click', () => {
			if (clickable) {
				clickable = false;
				prevBtn.style.display = 'none';
				currentIdx = (currentIdx - 1 + titleLists.length) % titleLists.length;
				leftTxt.innerText = titleLists[(currentIdx - 1 + titleLists.length) % titleLists.length];
				rightTxt.innerText = titleLists[(currentIdx + 2) % titleLists.length];

				setTimeout(() => {
					clickable = true;
					prevBtn.style.display = 'block';
				}, 500);
			}
		});

		//다음 버튼 누르면 다음 목록 뜨게 하기
		nextBtn.addEventListener('click', () => {
			if (clickable) {
				clickable = false;
				nextBtn.style.display = 'none';
				currentIdx = (currentIdx + 1) % titleLists.length;
				leftTxt.innerText = titleLists[(currentIdx - 1 + titleLists.length) % titleLists.length];
				rightTxt.innerText = titleLists[(currentIdx + 2) % titleLists.length];

				setTimeout(() => {
					clickable = true;
					nextBtn.style.display = 'block';
				}, 500);
			}
		});

		// Swiper: Slider
		new Swiper('.second', {
			loop: true,
			nextButton: '.swiper-button-next',
			prevButton: '.swiper-button-prev',
			slidesPerView: 2,
			paginationClickable: true,
			spaceBetween: 440,
			clickable: true,
			touchRatio: 0, //드래그 금지
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
	})
	.catch((err) => {
		console.log(err);
	});
