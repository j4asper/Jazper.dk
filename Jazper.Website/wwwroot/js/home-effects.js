window.jzHomeEffects = (function () {
  const reducedMotion = () => window.matchMedia("(prefers-reduced-motion: reduce)").matches;

  let typedTimer = null;

  function typeWords(words) {
    const el = document.getElementById("jz-typed-text");
    if (!el || !words || !words.length) return;

    if (reducedMotion()) {
      el.textContent = words.join(" · ");
      return;
    }

    let wordIndex = 0;
    let charIndex = 0;
    let direction = 1;

    const step = () => {
      const word = words[wordIndex % words.length];
      charIndex += direction;
      el.textContent = word.slice(0, Math.max(0, charIndex));

      let delay = direction > 0 ? 58 : 26;
      if (charIndex >= word.length) { direction = -1; delay = 1500; }
      else if (charIndex <= 0) { direction = 1; wordIndex++; delay = 300; }

      typedTimer = setTimeout(step, delay);
    };
    step();
  }

  let revealCleanup = null;

  function initReveal() {
    const els = Array.from(document.querySelectorAll("[data-reveal]"));
    if (!els.length || reducedMotion()) return;

    els.forEach((el, i) => {
      el.classList.add("jz-reveal-pending");
      el.style.transitionDelay = (Math.min(i % 6, 6) * 70) + "ms";
    });

    const show = el => {
      if (el.classList.contains("jz-reveal-in")) return;
      el.classList.add("jz-reveal-in");
    };

    const check = () => {
      const h = window.innerHeight || 800;
      els.forEach(el => {
        const r = el.getBoundingClientRect();
        if (r.top < h * 0.95 && r.bottom > 0) show(el);
      });
    };

    let rafId = null;
    const onScroll = () => {
      if (rafId) return;
      rafId = requestAnimationFrame(() => { rafId = null; check(); });
    };

    window.addEventListener("scroll", onScroll, { passive: true });
    window.addEventListener("resize", onScroll);
    check();
    const safety = setTimeout(() => els.forEach(show), 1200);

    revealCleanup = () => {
      window.removeEventListener("scroll", onScroll);
      window.removeEventListener("resize", onScroll);
      clearTimeout(safety);
    };
  }

  let glowCleanup = null;

  function initGlow() {
    const orb = document.getElementById("jz-orb");
    if (!orb || reducedMotion()) return;

    let raf = null, x = 0, y = 0;
    const onMove = ev => {
      x = ev.clientX; y = ev.clientY;
      if (raf) return;
      raf = requestAnimationFrame(() => {
        raf = null;
        orb.style.transform = "translate(" + (x - 320) + "px," + (y - 320) + "px)";
        orb.style.opacity = "1";
      });
    };
    const onLeave = () => { orb.style.opacity = "0"; };

    document.addEventListener("mousemove", onMove, { passive: true });
    document.addEventListener("mouseleave", onLeave);

    glowCleanup = () => {
      document.removeEventListener("mousemove", onMove);
      document.removeEventListener("mouseleave", onLeave);
    };
  }

  function init(words) {
    dispose();
    typeWords(words);
    initReveal();
    initGlow();
  }

  function dispose() {
    clearTimeout(typedTimer);
    if (revealCleanup) { revealCleanup(); revealCleanup = null; }
    if (glowCleanup) { glowCleanup(); glowCleanup = null; }
  }

  return { init, dispose };
})();
