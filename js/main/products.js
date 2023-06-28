//products
const productsSection = document.querySelector('#products');
const slideWrap = productsSection.querySelector('.slideWrap');
const slideItems = Array.from(productsSection.querySelectorAll('.slideItem'));
const leftArrowBtn = productsSection.querySelector('.leftArrowBtn');
const rightArrowBtn = productsSection.querySelector('.rightArrowBtn');

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
}
