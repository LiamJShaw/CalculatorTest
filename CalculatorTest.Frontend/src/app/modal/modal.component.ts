import { ChangeDetectionStrategy, Component, inject, signal } from '@angular/core';
import { CalculatorService } from '../services/calculator.service';

@Component({
  selector: 'app-modal',
  templateUrl: './modal.component.html',
  styleUrl: './modal.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ModalComponent {
  private readonly calculator = inject(CalculatorService);

  display = signal('0');
  expression = signal('');

  private start = 0;
  private fresh = true;

  digit(value: string): void {
    if (this.fresh) {
      this.display.set(value);
      this.fresh = false;
    } else {
      const current = this.display();
      this.display.set(current === '0' ? value : current + value);
    }
  }

  add(): void {
    this.start = parseInt(this.display());
    this.expression.set(`${this.start} +`);
    this.fresh = true;
  }

  subtract(): void {
    this.start = parseInt(this.display());
    this.expression.set(`${this.start} −`);
    this.fresh = true;
  }

  equals(): void {
    if (!this.expression()) return;

    const amount = parseInt(this.display());
    const isAdd = this.expression().endsWith('+');

    const call = isAdd
      ? this.calculator.add(this.start, amount)
      : this.calculator.subtract(this.start, amount);

    this.expression.set(`${this.expression()} ${amount} =`);

    call.subscribe({
      next: (r: number) => {
        this.display.set(String(r));
        this.fresh = true;
      },
      error: () => {
        this.display.set('Error');
        this.fresh = true;
      },
    });
  }

  clear(): void {
    this.display.set('0');
    this.expression.set('');
    this.start = 0;
    this.fresh = true;
  }
}
