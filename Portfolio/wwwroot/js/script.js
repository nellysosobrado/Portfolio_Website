﻿
document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', function (e) {
        e.preventDefault();
        document.querySelector(this.getAttribute('href')).scrollIntoView({
            behavior: 'smooth'
        });
    });
});

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


    function copyEmailToClipboard() {
            const email = "nelly.sosobrado@gmail.com";
            navigator.clipboard.writeText(email).then(() => {
        alert("Email address copied to clipboard!");
            }).catch(err => {
        console.error("Could not copy text: ", err);
            });
        }

document.addEventListener("DOMContentLoaded", () => {
    const carousel = document.getElementById("techstackCarousel");

    carousel.addEventListener("mouseenter", () => {
        carousel.style.animationPlayState = "paused";
    });

    carousel.addEventListener("mouseleave", () => {
        carousel.style.animationPlayState = "running";
    });
});
