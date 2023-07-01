// Go Top Button
const goTopBtn = document.querySelector('.goTopBtn');

goTopBtn.addEventListener('click', () => {
	window.scrollTo({ top: 0, left: 0, behavior: 'smooth' });
});
