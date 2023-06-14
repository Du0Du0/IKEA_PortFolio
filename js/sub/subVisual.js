const visualSection = document.querySelector('#visual');
const bgs = visualSection.querySelectorAll('.bg');
const pointBox1 = bgs[7];
const pointBox2 = bgs[12];

//visual pointBox toggle기능
pointBox1.addEventListener('click', (e) => {
	e.preventDefault();
	pointBox1.classList.add('on');
	pointBox2.classList.remove('on');

	if (e.target === pointBox1) {
		visualSection.style.background = 'url(img/news10.png)';
		visualSection.style.backgroundPosition = 'center';
		visualSection.style.backgroundRepeat = 'no-repeat';
		visualSection.style.backgroundSize = 'cover';
	} else return;
});

pointBox2.addEventListener('click', (e) => {
	e.preventDefault();

	pointBox2.classList.add('on');
	pointBox1.classList.remove('on');

	if (e.target === pointBox2) {
		visualSection.style.background = 'url(img/visual1.png)';
		visualSection.style.backgroundPosition = 'center';
		visualSection.style.backgroundRepeat = 'no-repeat';
		visualSection.style.backgroundSize = 'cover';
	} else return;
});
