//products
const productsSection = document.querySelector('#products');
const slideWrap = productsSection.querySelector('.slideWrap');
const slideItems = Array.from(productsSection.querySelectorAll('.slideItem'));
const nextBtn = productsSection.querySelector('.rigtArrowBtn');
const preBtn = productsSection.querySelector('.leftArrowBtn');

const pageTit = productsSection.querySelector('.productsTit h2');

let tags = '';

fetch('DB/products.json')
	.then((res) => res.json())
	.then((data) => {
		const productsData = data.products;

		productsData.map((data) => {
			tags += `
				<div class="slideItem">
				<div class="productsImg">
				<img src="img/${data.pic}"/>
				</div>
				<div class="productsName">${data.category}</div>
				</div>`;
		});
		slideWrap.innerHTML = tags;
		duplicateSlides();
	})

	.catch((err) => {
		console.log(err);
	});

//products 슬라이드 무한반복 기능
function duplicateSlides() {
	const numSlides = slideItems.length;

	for (let i = 0; i < numSlides; i++) {
		const clonedSlide = slideItems[i].cloneNode(true);
		slideWrap.appendChild(clonedSlide);
	}

	// products next button move
	let count = 0;
	nextBtn.addEventListener('click', () => {
		count++;
		console.log('+');
		slideWrap.style.transform = `translateX(-${count * 400}px)`;

		if (count * 400 == 4000) {
			setTimeout(() => {
				count = 0;
				preBtn.style.backgroundColor = '#cacaca';
				slideWrap.style.transform = `translateX(0)`;
			}, 300);
		} else if (count > 0) {
			preBtn.style.backgroundColor = '#171717';
		}
	});

	// products prev button move
	preBtn.addEventListener('click', () => {
		count--;
		console.log('-');
		console.log(count);
		slideWrap.style.transform = `translateX(-${count * 400}px)`;

		if (count <= 0) {
			setTimeout(() => {
				count = 0;
				preBtn.style.backgroundColor = '#cacaca';
				slideWrap.style.transform = `translateX(0)`;
			}, 300);
		}
	});
}

window.addEventListener('scroll', () => {
	let value = window.scrollY;
	console.log('scrollY', value);

	if (value > 300) {
		pageTit.style.animation = 'slide 1s ease-out forwards ';
	} else {
		pageTit.style.animation = 'slideBack 1s ease-out forwards';
	}

	if (value > 1100) {
		pageTit.style.animation = 'slideBack 1s ease-out forwards';
	}
});
