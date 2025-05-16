// Smooth scrolling för navigation
document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', function (e) {
        e.preventDefault();
        document.querySelector(this.getAttribute('href')).scrollIntoView({
            behavior: 'smooth'
        });
    });
});

// Hantera kontaktformulär
document.getElementById('contact-form').addEventListener('submit', function (e) {
    e.preventDefault();
    // Här kan du lägga till kod för att hantera formuläret
    alert('Tack för ditt meddelande! Jag återkommer så snart som möjligt.');
    this.reset();
});

// Enkel animation för projekt-kort
const projectCards = document.querySelectorAll('.project-card');
projectCards.forEach(card => {
    card.addEventListener('mouseenter', () => {
        card.style.transform = 'translateY(-5px)';
        card.style.transition = 'transform 0.3s ease';
    });

    card.addEventListener('mouseleave', () => {
        card.style.transform = 'translateY(0)';
    });
});

function copyEmail() {
    navigator.clipboard.writeText('nelly.sosobrado@gmail.com');
    alert('copied "nelly.sosobrado@gmail.com" to clipboard!');
} 

